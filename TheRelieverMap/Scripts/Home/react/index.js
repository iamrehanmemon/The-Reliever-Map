import React from 'react';
import { render } from 'react-dom';
import { BrowserRouter, Route } from "react-router-dom";

import HomePage from "../react/pages/homepage/homepage.component"
import AddFormToilet from './components/addformtoilet/addformtoilet.component';
import Navbar from './components/navbar/navbar.component';



const App = () => (
    <React.Fragment>
        <BrowserRouter>
            <Navbar/>
            <Route path="/" exact>
                <HomePage />
            </Route>
            <Route path="/AddToilet/Add" component={ AddFormToilet}/>
        </BrowserRouter>
    </React.Fragment>
);

render(<App />, document.getElementById('app'));
