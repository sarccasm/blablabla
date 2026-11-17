# Результати локальної перевірки

- .NET SDK: 9.0.202, macOS x64.
- `dotnet build`: 0 помилок, 0 попереджень.
- `dotnet run --no-build --launch-profile http --urls http://127.0.0.1:5080`: сервер запущено.
- Головна сторінка містить час із сервісу та посилання `/Products`.
- Скриншот `home.png` зроблено headless Google Chrome з локального сервера.

Фрагмент фактичних middleware-логів:

```text
GET / => 200
GET /Products => 200
GET /missing => 404
GET /css/site.css => 200
GET /favicon.ico => 200
```
