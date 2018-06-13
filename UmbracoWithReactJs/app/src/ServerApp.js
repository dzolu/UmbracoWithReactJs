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
import Head from "./containers/Head";
import PeopleContainer from "./containers/PeopleContainer";

const App = (props) => {
    const store = configureStore(props.masterModel.InitialState);

    return (
        <Provider store={store}>
            <Router location={props.masterModel.InitialState.Request.Location}>
                <div>
                    <Head/>
                    <MobileNav topNavigation={props.masterModel.TopNavigation}/>
                    <Header topNavigation={props.masterModel.TopNavigation}/>
                    <main>
                        <Route path="/" component={HomeContainer} exact></Route>
                        <Route path="/people" component={PeopleContainer}></Route>
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
