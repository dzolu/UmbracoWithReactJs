import React, {Component} from 'react';
import './App.css';
import PropTypes from "prop-types";
import {BrowserRouter as Router, Route} from 'react-router-dom';
import configureStore from "./store/configureStore";
import {Provider} from "react-redux";
import Footer from "./Footer";
import MainNavigation from "./MainNavigation";
import Kantory from "./Kantory";
import Contact from "./Contact";
const App = (props) => {
    const store = configureStore(props.initialState, window.__REDUX_DEVTOOLS_EXTENSION__ && window.__REDUX_DEVTOOLS_EXTENSION__());
    return (

        <Provider store={store}>
            <Router>
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
