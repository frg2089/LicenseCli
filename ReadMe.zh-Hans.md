# License Cli

一个用于生成许可证文件的命令行工具，支持多种开源许可证格式。

## 功能特点

- 🚀 快速生成标准许可证文件
- 📝 支持自定义作者和版权信息
- 🔍 支持搜索和查找许可证
- 📦 自动缓存许可证信息

## 安装

```bash
dotnet tool install --global LicenseCli
```

## 使用方法

### 创建许可证文件

```bash
# 创建 MIT 许可证
dotnet license new MIT

# 创建带有作者信息的许可证
dotnet license new MIT "Your Name"

# 指定输出路径
dotnet license new MIT -o /path/to/LICENSE

# 静默模式（不输出到控制台）
dotnet license new MIT -q
```

### 搜索许可证

```bash
# 搜索许可证
dotnet license search gpl
```

## 贡献

欢迎提交 Issue 和 Pull Request 来帮助改进这个项目。

## 许可证

本项目本身采用 MIT 许可证开源。