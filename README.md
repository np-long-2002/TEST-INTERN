<h2>Hệ thống bán hàng đơn giản (POS) gồm:</h2>
<ul>
  <li>Frontend: ReactJS</li>
  <li>Backend: ASP.NET Core Web API</li>
  <li>Data: In-memory</li>
</ul>

<br>

<h3>Yêu cầu</h3>
<ul>
  <li>Node.js &gt;= 18</li>
  <li>.NET SDK &gt;= 8.0</li>
  <li>Docker Desktop</li>
</ul>

<h3>Backend Run</h3>
<pre>
cd posapi
dotnet run
</pre>

<p>=&gt; http://localhost:5232/swagger</p>

<h3>Fontend Run</h3>
<pre>
cd pos-fe
npm start
</pre>

<p>=&gt; http://localhost:3000/pos</p>
<p>=&gt; http://localhost:3000/realtime</p>

<h3>Docker</h3>

<h4>BE</h4>
<pre>
docker build -t pos-api .
docker run -d -p 5232:5232 pos-api
</pre>

<h4>FE</h4>
<pre>
docker build -t pos-api .
docker run -d -p 5232:5232 pos-api
</pre>
