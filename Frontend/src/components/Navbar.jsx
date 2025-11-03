import React from "react";
import "../styles/Navbar.css";

const Navbar = () => {
  return (
    <nav className="navbar">
      <div className="navbar-logo"><a href="#">CG INFINITY STORE 🛍️</a></div>
      <ul className="navbar-links">
        <li><a href="#">Home</a></li>
        <li><a href="#">Shop</a></li>
        <li><a href="#">About</a></li>
        <li><a href="#">Contact</a></li>
      </ul>
      <button className="navbar-btn">Login</button>
    </nav>
  );
};

export default Navbar;