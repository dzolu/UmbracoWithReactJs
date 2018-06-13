import React, {Component} from 'react';
import './App.css';
import {
    StaticRouter as Router,
    Route
} from 'react-router';

import configureStore from "./redux/store/configureStoreServer";
import {Provider} from "react-redux";
import HomeContainer from "./containers/HomeContainer"
import PropTypes from "prop-types";
import MobileNav from "./components/MobileNav";
import Header from "./components/Header";

const App = (props) => {
    const store = configureStore(props.masterModel.InitialState);

    return (
        <Provider store={store}>
            <Router location={props.masterModel.InitialState.Request.Location}>
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

App.propTypes = {
    masterModel: PropTypes.object.isRequired
};


export default App;
