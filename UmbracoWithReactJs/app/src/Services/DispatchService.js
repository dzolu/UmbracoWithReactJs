class DispatchService {
    static routeChange(props, data) {
        const {MetaData, Content, Request} = data;
        const {updateMetaData, updateContent, updateRequest} = props.contentActions;
        !!MetaData && updateMetaData(MetaData);
        !!Content && updateContent(Content);
        !!Request && updateRequest(Request);

    }

    static initalLoadDone(props) {
        props.ajaxContainerActions.updateAjaxRequestFlag(true);
    }
}

export default DispatchService;