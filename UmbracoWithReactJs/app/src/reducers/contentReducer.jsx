import * as Types from "../actions/actionTypes";

export default function conntentReducer(state="", action) {
    switch (action.type) {
        case Types.UPDATE_CONTENT:
            return Object.assign({}, state, {Content: action.content});
        default:
            return state;
    }
}