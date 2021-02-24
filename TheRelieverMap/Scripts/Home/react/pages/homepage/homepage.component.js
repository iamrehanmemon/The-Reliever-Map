import React from 'react';
import { render } from 'react-dom';

import Hero from "/Scripts/Home/react/components/hero/hero.component.js";
import Services from "/Scripts/Home/react/components/services/services.component.js";
import Feature from "/Scripts/Home/react/components/feature/feature.component.js";



const HomePage = () => (
    <div>
        <Hero />
        <Services />
        <Feature />
    </div>
);

export default HomePage;
