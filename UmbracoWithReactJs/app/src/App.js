import React, {Component} from 'react';
import './App.css';
import PropTypes from "prop-types";
import {BrowserRouter as Router, Route} from 'react-router-dom';
import configureStore from "./store/configureStore";
import {Provider} from "react-redux";
import HomeContainer from "./containerComponents/HomeContainer";
import Header from "./presentationComponents/Header";
import MobileNav from "./presentationComponents/MobileNav";
const App = (props) => {
    const store = configureStore(props.masterModel.InitialState);
    
    return (
        <Provider store={store}>
            <Router>
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
