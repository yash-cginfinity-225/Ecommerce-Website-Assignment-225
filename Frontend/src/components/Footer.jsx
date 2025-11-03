import React from "react";
import "../styles/Footer.css";

const Footer = () => {
    return (
        <footer className="footer">
            <div className="footer-content">
                <div className="footer-logo">CG Infinity Peripherals Store Pvt. Ltd.</div>
                <p className="footer-text">
                    © {new Date().getFullYear()} CG Infinity. All rights reserved.
                </p>
                <div className="footer-links">
                    <a href="#">Privacy Policy</a>
                    <a href="#">Terms</a>
                    <a href="#">Support</a>
                </div>
            </div>
        </footer>
    );
};

export default Footer;