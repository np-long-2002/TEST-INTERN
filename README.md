Hệ thống bán hàng đơn giản (POS) gồm:
+ Frontend: ReactJS
+ Backend: ASP.NET Core Web API
+ Data: In-memory
Yêu cầu
+ Node.js >= 18
+ .NET SDK >= 8.0
+ Docker Desktop
Backend Run
+ cd posapi
+ dotnet run
==> http://localhost:5232/swagger
Fontend Run
+ cd pos-fe
+ npm start
==> http://localhost:3000/pos
==> http://localhost:3000/realtime
Docker
+BE
  - docker build -t pos-api .
  - docker run -d -p 5232:5232 pos-api
+FE
  - docker build -t pos-api .
  - docker run -d -p 5232:5232 pos-api




