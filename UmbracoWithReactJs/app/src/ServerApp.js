import React, {Component} from 'react';
import './App.css';
import {
    StaticRouter as Router,
    Route
} from 'react-router';

import configureStore from "./store/configureStore";
import {Provider} from "react-redux";
import HomeContainer from "./containerComponents/HomeContainer"



import PropTypes from "prop-types";

const App = (props) => {
    const store = configureStore(props.initialState);
    return (
        <Provider store={store}>
            <Router  location={props.initialState.Request.Location}>
                <div>
                    <main>
                        <Route path="/" component={HomeContainer} exact></Route>
                    </main>
                </div>
            </Router>
        </Provider>
    );

};

App.propTypes={
    initialState: PropTypes.object.isRequired
};



export default App;
