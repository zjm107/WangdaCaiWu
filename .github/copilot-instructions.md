# WangDa Caiwu 项目 - AI 编程助手指南

## 项目概览
**WangDa Caiwa** (旺达财务代理管理系统) 是一个 .NET Framework 4.8 财务管理应用，采用分层架构：

- **WDServer**: 后端 Web 服务（ASMX Web Services）
- **WangDaApp**: Windows Forms 桌面客户端（WinExe）
- **Tiger.PdrCommon**: 公共业务逻辑库
- **Tiger.CoreClass.Data**: 数据访问层（DAL）
- **Tiger.Config**: 配置库（依赖于 Tiger.CoreClass.Data）
- **Tiger.WinTools**: Windows 工具库

## 关键架构模式

### 1. 数据访问层（DAL）- Tiger.CoreClass.Data
**文件**: [Tiger.CoreClass.Data/](Tiger.CoreClass.Data/)

- **抽象设计**: `AbsDatabase` 是数据库操作的抽象基类，支持多数据库类型
- **具体实现**: `SqlDatabase`（SQL Server）、`OleDbDatabase`
- **服务管理**: `ServiceManager` 是单例工厂，负责：
  - 从 `app.config` 加载数据源配置（`<dataSources>`）
  - 管理数据库连接池和实体缓存
  - 通过 `ServiceManager.GetDatabase()` 获取数据库实例

```csharp
// 典型用法：
DataSet ds = ServiceManager.GetDatabase().GetEntity(strSql, "TableName");
```

### 2. 加密解密机制
**文件**: [Tiger.CoreClass.Data/EnDecrypt.cs](Tiger.CoreClass.Data/EnDecrypt.cs)

- SQL 查询和敏感数据通过 `EnDecrypt.Decrypt()` 解密后执行
- 关键安全检查：`BaseSer.ExeSelectSQL()` 中禁止 DELETE/UPDATE/CREATE/DROP/EXEC 操作
- **流程**: 加密SQL → 传输 → Decrypt → 执行前验证 → 返回DataSet

### 3. Web 服务（ASMX）- 后端
**文件**: [WDServer/](WDServer/)

主要服务包括：
- `WangDaSer.asmx`: 财务数据核心服务（7000+ 行）
- `BasicService.asmx`: 基础服务
- `Config.asmx`: 配置服务
- `UserSer.asmx`: 用户服务

特点：
- 使用 `[WebMethod]` 装饰的公共方法暴露为 Web 端点
- 直接操作 SQL Server 数据库（表名使用 Chinese 列名如 `客户名称`、`注册员`）
- 返回 `DataSet` 供客户端反序列化

### 4. Windows Forms 客户端 - WangDaApp
**文件**: [WangDaApp/](WangDaApp/)

- 通过 SOAP Web 服务调用后端
- `app.config` 配置服务端点（支持本地和远程地址）
- 使用 DevExpress 控件库（参考 Res/DevExpressLocalizedResources 配置）
- ClickOnce 发布配置在 WangDaApp.csproj 中（发布地址: `http://WIN-ONUJ1V8AC54/WangDaApp/`）

### 5. 配置系统
**文件**: [Tiger.Config/](Tiger.Config/), [Tiger.ConfigApp/](Tiger.ConfigApp/)

- `Tiger.Config`: 库，通过 `BaseSer` 执行数据库操作
- `Tiger.ConfigApp`: Winform 配置工具，用于管理系统配置（公司、URL、业务流程等）

## 关键文件概览

| 文件 | 用途 |
|------|------|
| [Tiger.CoreClass.Data/ServiceManager.cs](Tiger.CoreClass.Data/ServiceManager.cs) | 数据库连接管理（单例工厂）|
| [Tiger.CoreClass.Data/AbsDatabase.cs](Tiger.CoreClass.Data/AbsDatabase.cs) | DAL 抽象基类，事务管理 |
| [WDServer/WangDaSer.asmx.cs](WDServer/WangDaSer.asmx.cs) | 主业务逻辑 Web 服务 |
| [Tiger.Config/BaseSer.cs](Tiger.Config/BaseSer.cs) | 数据库操作基类，SQL 加密验证 |
| [WangDaApp/app.config](WangDaApp/app.config) | 客户端 Web 服务端点配置 |

## 开发工作流

### 编译构建
```bash
# 使用 MSBuild 编译（.NET Framework 项目）
msbuild WangDaSolution.sln /p:Configuration=Debug /p:Platform="AnyCPU"
```

### 数据库连接配置
- **服务端**: WDServer\Web.config 中配置 `<dataSources>` 连接字符串
- **客户端**: WangDaApp\app.config 中配置 Web 服务地址
- 示例: `http://localhost:2857/BaseSer.asmx` 或远程地址 `http://WIN-ONUJ1V8AC54/BaseSer.asmx`

### 常见任务
1. **添加新的 Web 方法**: 在 [WDServer/WangDaSer.asmx.cs](WDServer/WangDaSer.asmx.cs) 中添加 `[WebMethod]` 方法
2. **修改数据库操作**: 修改 SQL 语句，注意中文列名和表名
3. **修改 UI**: 编辑 [WangDaApp/](WangDaApp/) 中的 Winform 设计器文件
4. **更新配置**: 使用 Tiger.ConfigApp 或直接修改 app.config/Web.config

## 编码约定

- **命名**: 类使用 `Tiger.*` 或 `WangDa*` 前缀；Web 服务 asmx 文件
- **SQL**: 使用中文列名（如 `客户名称`, `业务员`）；SQL 需加密传输
- **异常处理**: 捕获异常并包装为更详细的 Exception（见 BaseSer.cs）
- **事务**: 通过 `BeginTrans()` / `CommitTrans()` / `RollbackTrans()` 管理
- **.NET Framework**: 项目固定为 4.8 版本

## 关键依赖

- **log4net 3.2.0**: 日志框架（参考 packages/ 目录）
- **Microsoft.CodeDom.Providers.DotNetCompilerPlatform 1.0.3**
- **DevExpress**: UI 控件库（WinForm）

## 常见陷阱与解决方案

| 问题 | 解决方案 |
|------|--------|
| SQL 执行失败，列名找不到 | 检查中文列名是否正确（如 `客户名称` vs `CustomerName`）|
| Web 服务无法访问 | 验证 WDServer 是否部署到正确的 IIS，检查 app.config 端点配置 |
| 事务未提交 | 确保调用 `CommitTrans()`，未提交时数据会回滚 |
| 加密数据解析错误 | SQL 通过 `EnDecrypt.Decrypt()` 解密，密钥存储在 [KeyInfo.cs](Tiger.CoreClass.Data/KeyInfo.cs) |

## 性能优化建议

- 使用 `ServiceManager` 的连接池，避免创建新连接
- 缓存 DataSet Schema：[ServiceManager.cs 第 39-50 行](Tiger.CoreClass.Data/ServiceManager.cs#L39-L50)
- 大数据量查询使用分页
