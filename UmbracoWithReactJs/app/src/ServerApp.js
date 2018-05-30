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
import MobileNav from "./presentationComponents/MobileNav";
import Header from "./presentationComponents/Header";

const App = (props) => {
    const store = configureStore(props.masterModel.InitialState);
   
    return (
        <Provider store={store}>
            <Router  location={props.masterModel.InitialState.Request.Location}>
                <div>
                    <MobileNav topNavigation={props.masterModel.TopNavigation}/>
                    <Header topNavigation={props.masterModel.TopNavigation}/>
                    <main>
                        <div>
                            <Route path="/" component={HomeContainer} exact></Route>
                        </div>
                    </main>
                </div>
            </Router>
        </Provider>
    );

};

App.propTypes={
    masterModel: PropTypes.object.isRequired
};



export default App;
