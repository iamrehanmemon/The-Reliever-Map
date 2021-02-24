import React from 'react';
import { render } from 'react-dom';
import { BrowserRouter, Route } from "react-router-dom";

import HomePage from "../react/pages/homepage/homepage.component"




const App = () => (
    <React.Fragment>
        <BrowserRouter>
            <Route path="/" exact>
                <HomePage />
            </Route>
        </BrowserRouter>
    </React.Fragment>
);

render(<App />, document.getElementById('app'));
