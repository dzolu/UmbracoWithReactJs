import React, {Component} from 'react';
import './App.css';
import {
    StaticRouter as Router,
    Route
} from 'react-router';

import configureStore from "./store/configureStore";
import {Provider} from "react-redux";
import MainNavigation from "./MainNavigation";
import Footer from "./Footer";

import Contact from "./Contact";
import Kantory from "./Kantory";
import PropTypes from "prop-types";

const App = (props) => {
    const store = configureStore(props.initialState);
    return (
        <Provider store={store}>
            <Router  location={props.initialState.Request.Location}>
                <div>
                    <MainNavigation/>
                    <div>
                        <Route path="/" component={Kantory} exact></Route>
                        <Route path="/kontakt" component={Contact}/>
                        <Route path="/kantory-internetowe" component={Kantory}></Route>
                    </div>
                    <Footer/>
                </div>
               
            </Router>
        </Provider>
    );

};

App.propTypes={
    initialState: PropTypes.object.isRequired
};



export default App;
