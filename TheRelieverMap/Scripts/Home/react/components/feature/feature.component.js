import React from "react";

import map from "../../assets/images/map.png";

import "./feature.css";

const Feature = () => (
    <div className="feature-container">
        <img className="feature-img" src={map} alt="map" />
        <h2 className="feature-title">
            Open data Database 
        </h2>
        <p className="services-desc">
            We rely on user generated content but also on official open data databases available and created by cities over the world.
            We respect the usage, distribution and redistribution rules included in their included license.
        </p>

    </div>
);

export default Feature;