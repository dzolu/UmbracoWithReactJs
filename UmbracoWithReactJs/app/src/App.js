import React, {Component} from 'react';
import './App.css';
import PropTypes from "prop-types";
import {BrowserRouter as Router, Route} from 'react-router-dom';
import configureStore from "./store/configureStore";
import {Provider} from "react-redux";
import HomeContainer from "./containerComponents/HomeContainer";
const App = (props) => {
    const store = configureStore(props.initialState, window.__REDUX_DEVTOOLS_EXTENSION__ && window.__REDUX_DEVTOOLS_EXTENSION__());
    return (
        <Provider store={store}>
            <Router>
                <main>
                    <div>
                        <Route path="/" component={HomeContainer} exact></Route>
                    </div>
                </main>
            </Router>

        </Provider>


    );
};

App.propTypes={
    initialState: PropTypes.object.isRequired
};

export default App;
