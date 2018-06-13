import  {createStore,applyMiddleware,compose} from 'redux'
import rootReducer from '../reducers/index';
import reduxImmutableStateInvariant from 'redux-immutable-state-invariant'
import thunk from 'redux-thunk';
import createHistory from "history/createBrowserHistory";
import {routerMiddleware} from "react-router-redux";
const history= createHistory();
const middleware=routerMiddleware(history);
const composeEnhancers=window.__REDUX_DEVTOOLS_EXTENSION_COMPOSE__ || compose;

export default function configureStore(initialState) {
    return createStore(rootReducer, initialState, composeEnhancers(applyMiddleware(...middleware, thunk, reduxImmutableStateInvariant())));
}