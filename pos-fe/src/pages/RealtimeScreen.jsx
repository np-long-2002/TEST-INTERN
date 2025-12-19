import { useEffect, useState } from "react";
import * as signalR from "@microsoft/signalr";
import axios from "axios";

const API_URL = "http://localhost:5232"; 

function RealtimeScreen() {
  const [orders, setOrders] = useState([]);

  useEffect(() => {
    axios.get(`${API_URL}/api/orders`)
      .then(res => setOrders(res.data));

    const connection = new signalR.HubConnectionBuilder()
      .withUrl(`${API_URL}/orderHub`)
      .withAutomaticReconnect()
      .build();

    connection.start()
      .then(() => console.log("SignalR connected"))
      .catch(err => console.error(err));

    connection.on("OrderCreated", (order) => {
      setOrders(prev => [order, ...prev]);
    });

    return () => {
      connection.stop();
    };
  }, []);

  return (
    <div>
      <h2>Đơn hàng</h2>

      {orders.map(o => (
        <div key={o.id}>
          <p>Mã đơn: {o.id}</p>
          <p>Tổng tiền: {o.total}</p>
          <p>Thời gian: {new Date(o.createdAt).toLocaleString()}</p>
          <hr />
        </div>
      ))}
    </div>
  );
}

export default RealtimeScreen;
