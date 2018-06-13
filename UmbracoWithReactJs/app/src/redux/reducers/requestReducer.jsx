import * as Types from '../actions/actionTypes';

export default function requestReducer(state = {}, action) {
    switch (action.type) {
        case Types.IS_AJAX_REQUEST:
            return Object.assign({}, state, {IsAjaxRequest: action.isAjaxRequest});
        case Types.UPDATE_LOCATION:
            return Object.assign({}, state, {Location: action.Location});
        case Types.UPDATE_REQUEST:
            return Object.assign({}, state, action.request);
        default:
            return state;
    }
}