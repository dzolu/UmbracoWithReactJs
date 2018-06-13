import * as Types from "../actions/actionTypes";

export default function metaDataReducer(state = "", action) {
    switch (action.type) {
        case Types.UPDATE_METADATA:
            return Object.assign({}, state, action.metaData);
        default:
            return state;
    }
}