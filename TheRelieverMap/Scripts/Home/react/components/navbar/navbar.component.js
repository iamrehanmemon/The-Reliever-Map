import React from "react";
import { Link } from "react-router-dom";

const Navbar = () => (
    <div className="navbar">
        <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <li>
                        <Link to="/" className="navbar-brand">
                            The Reliver Map
                        </Link>
                    </li>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li>
                            <Link to="/Home/About">
                                About
                            </Link>
                        </li>
                        <li>
                            <Link to="/AddToilet/Add">
                                Add Toilet
                            </Link>
                        </li>
                    </ul>
                </div>

            </div>
        </div>
    </div>
);

export default Navbar;