import React, {Component} from 'react';
import './App.css';
import PropTypes from "prop-types";
import {BrowserRouter as Router, Route} from 'react-router-dom';
import configureStore from "./store/configureStore";
import {Provider} from "react-redux";
import HomeContainer from "./containerComponents/HomeContainer";
import TopNavigation from "./presentationComponents/TopNavigation";
const App = (props) => {
    const store = configureStore(props.masterModel.InitialState);
    
    return (
        <Provider store={store}>
            <Router>
                <div>
                    <TopNavigation topNavigation={props.masterModel.TopNavigation}/>
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
