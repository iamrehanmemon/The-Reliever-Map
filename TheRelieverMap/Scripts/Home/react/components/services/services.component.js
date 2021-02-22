import React from "react";

import community from "../../assets/images/community.png";
import city from "../../assets/images/city.png";
import partner from "../../assets/images/partner.png";

import "./services.css";

const Services = () => (
    <div className="services-container">
        <h1 className="services-header">
            Our Services   
        </h1>
        <div className="services-wrapper">
            <div className="services-card">
                <img className="services-img" src={community} alt="community" />
                <h2 className="services-title">You are a User</h2>
                <div className="services-info">
                    <p className="services-desc">
                        You want to share your experience? You have some suggestions to enhance our application?
                        You want to share your happiness or your disappointment?
                        You have any question or want some extra information?
                    </p>
                </div>
            </div>
            <div className="services-card">
                <img className="services-img" src={city} alt="city" />
                <h2 className="services-title">You are a City representative</h2>
                <div className="services-info">
                    <p className="services-desc">
                        You have public toilets on your premises and you’d like them to be included in our database?
                        You have paper or digital documents you’d like to share with us and appear as an official city contributor in our application?
                    </p>
                </div>
            </div>
            <div className="services-card">
                <img className="services-img" src={partner} alt="partner" />
                <h2 className="services-title">You are a Brand representative</h2>
                 <div className="services-info">
                    <p className="services-desc">
                        You want to promote your brand through our application?
                        You want some visibility and, for instance, want to display your retail shops in our app?
                    </p>
                </div>
            </div>

        </div>

    </div>
);

export default Services;