import * as Types from "./actionTypes";

export function updateAjaxRequestFlag(isAjaxRequest) {
    return{type:Types.IS_AJAX_REQUEST, isAjaxRequest}
}