import './Style/App.css';
import React, { useState } from "react";
import {
  Route,
  Routes
} from "react-router-dom";
import Home from './Pages/Home';
import SignUp from './Pages/SignUp';
import NotFound from './Pages/NotFound';
import SignInSide from './Pages/SignIn';
import Conversa from './Pages/Conversa';

function App() {
  const [user, setUser] = useState(null);
  return (
       <Routes>
          <Route exact path="/" element={<Home user={user} setUser={setUser} />} />
          <Route exact path="/signIn" element={<SignInSide user={user} setUser={setUser} />} />
          <Route exact path="/signUp" element={<SignUp />} user={user} setUser={setUser} />
          <Route path="/:id" element={<Conversa />} user={user} setUser={setUser} />
          <Route path="*" element={<NotFound />} />
       </Routes>
  );
}

export default App;
