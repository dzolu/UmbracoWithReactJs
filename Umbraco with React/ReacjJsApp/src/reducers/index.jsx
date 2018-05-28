import {combineReducers} from 'redux';
import Content from './contentReducer';
import MetaData from './metaDataReducer';
import Request from "./RequestReducer";

const rootReducer= combineReducers({
    MetaData,
    Content,
    Request
});

export default rootReducer;