import * as Types from './actionTypes';

export function updateContent(content) {
    return{type:Types.UPDATE_CONTENT, content}
}

export function updateMetaData(metaData) {
    return{type:Types.UPDATE_METADATA, metaData}
}

export function updateRequest(request) {
    return{type:Types.UPDATE_REQUEST, request}
}