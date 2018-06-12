import * as Types from "../actions/actionTypes";
import queryParameters from "./queryParametersReducer"

export default function conntentReducer(state ={}, action) {
    switch (action.type) {
        case Types.UPDATE_CONTENT:
            return action.content;
        case Types.AMOUNT_TO_SEND:
            return { ...state, QueryParameters: queryParameters(state.QueryParameters, action)};
        default:
            return state;
    }
}
