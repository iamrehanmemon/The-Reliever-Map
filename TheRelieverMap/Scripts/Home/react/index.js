import React from 'react';
import { render } from 'react-dom';
import Hero from "/Scripts/Home/react/components/hero/hero.component.js";
import Services from "/Scripts/Home/react/components/services/services.component.js";
import Feature from "/Scripts/Home/react/components/feature/feature.component.js";



const App = () => (
    <React.Fragment>
        <Hero />
        <Services />
        <Feature />
    </React.Fragment>
);

render(<App />, document.getElementById('app'));
