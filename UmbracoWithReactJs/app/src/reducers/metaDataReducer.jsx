import * as Types from "../actions/actionTypes";

export default function metaDataReducer(state="", action) {
    switch (action.type) {
        case Types.UPDATE_METADATA:
            return Object.assign({},  action.metaData);
        default:
            return state;
    }
}