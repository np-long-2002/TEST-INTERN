import { useEffect, useState } from "react";
import api from "../services/api";

function PosScreen() {
  const [products, setProducts] = useState([]);
  const [cart, setCart] = useState([]);

  useEffect(() => {
    api.get("/products").then(res => setProducts(res.data));
  }, []);

  const addToCart = (product) => {
    setCart([...cart, { ...product, quantity: 1 }]);
  };

  const total = cart.reduce(
    (sum, item) => sum + item.price * item.quantity,
    0
  );

  const checkout = async () => {
    await api.post("/orders", {
      items: cart.map(c => ({
        productId: c.id,
        productName: c.name,
        price: c.price,
        quantity: c.quantity
      }))
    });

    alert("Thanh toán thành công!");
    setCart([]);
  };

  return (
    <div>
      <h1>BÁN HÀNG</h1>

      <h2>Sản phẩm</h2>
      {products.map(p => (
        <div key={p.id}>
          {p.name} - {p.price.toLocaleString()}đ
          <button onClick={() => addToCart(p)}>Thêm</button>
        </div>
      ))}

      <h2>Giỏ hàng</h2>
      {cart.map((c, i) => (
        <div key={i}>
          {c.name} x {c.quantity} = {(c.price * c.quantity).toLocaleString()}đ
        </div>
      ))}

      <h3>Tổng tiền: {total.toLocaleString()}đ</h3>

      <button onClick={checkout} disabled={cart.length === 0}>
        Thanh toán
      </button>
    </div>
  );
}

export default PosScreen;
