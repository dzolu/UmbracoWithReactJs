import * as Types from "../actions/actionTypes";

export default function conntentReducer(state = {}, action) {
    switch (action.type) {
        case Types.UPDATE_CONTENT:
            return action.content;
        default:
            return state;
    }
}
