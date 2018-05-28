import React, {Component} from 'react';
import './App.css';
import PropTypes from "prop-types";
import {BrowserRouter as Router, Route} from 'react-router-dom';
import configureStore from "./store/configureStore";
import {Provider} from "react-redux";


const App = (props) => {
   // const store = configureStore(props.initialState, window.__REDUX_DEVTOOLS_EXTENSION__ && window.__REDUX_DEVTOOLS_EXTENSION__());
    return (

        <Router >
            <div>
                <div>Hello world</div>
            </div>

        </Router>


    );
};

// 

export default App;
