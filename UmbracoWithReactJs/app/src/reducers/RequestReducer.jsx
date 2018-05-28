import * as Types from '../actions/actionTypes';

export default function queryParameters(state = {}, action) {
    switch (action.type) {
        case Types.IS_AJAX_REQUEST:
            return Object.assign({}, state, {IsAjaxRequest: action.isAjaxRequest});
        default:
            return state;
    }
}