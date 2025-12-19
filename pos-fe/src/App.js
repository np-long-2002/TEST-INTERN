import { BrowserRouter, Routes, Route } from "react-router-dom";
import PosScreen from "./pages/PosScreen";
import RealtimeScreen from "./pages/RealtimeScreen";

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/pos" element={<PosScreen />} />
        <Route path="/realtime" element={<RealtimeScreen />} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
