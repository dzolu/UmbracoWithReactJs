import {combineReducers} from 'redux';
import Content from './contentReducer';
import MetaData from './metaDataReducer';
import Request from "./requestReducer";

const rootReducer = combineReducers({
    MetaData,
    Content,
    Request
});

export default rootReducer;