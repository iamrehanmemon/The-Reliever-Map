import React from "react";

import runningdog from "../../assets/images/running-dog.png";
import youtubelogo from "../../assets/icons/youtube.svg";
import twitchlogo from "../../assets/icons/twitch.svg";


import "./hero.css";

const Hero = () => (
    <div className="hero container">
        <div
            className="hero__content"   

        >
            <h1>A new way to find out what's on.</h1>
            <p>
                Sign up with your Google or Facebook account and get access to information 
                on public Restrooms in your Area. Want more info?
            <a className="link" href="#">
                        Check out our video at YouTube.
            </a>
            </p>
            <button className="btn">
                <span className="btn__text">Sign Up with The Reliever Map</span>
            </button>
        </div>

        <div className="hero__img">
            <div className="hero__img--1">
                <img
                    src={twitchlogo}
                    className="icon-1"
                    alt="twitch logo"
                    height="80"
                    width="80"
                />
                <img
                    src={youtubelogo}
                    className="icon-2"
                    alt="youtube logo"
                    height="80"
                    width="80"
                />
            </div>

            <div className="hero__img--2">
                <img src={runningdog} alt="running dog" />
            </div>
        </div>
    </div>
);

export default Hero;