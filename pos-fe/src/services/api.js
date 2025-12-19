import axios from "axios";

const api = axios.create({
  baseURL: "http://localhost:5232/api",
});

export default api;
