import React, {Component} from 'react';
import WithLoading from "./WithLoading";
import axios from "axios";
import {connect} from "react-redux";
import * as ajaxContainerActions from "./../actions/ajaxContainerActions";
import * as contentActions from "./../actions/contentActions"
import {bindActionCreators} from "redux";

const AjaxComponent = (WrappedComponent) => {
    const  ComponentWithLoader = WithLoading(WrappedComponent);
     class AjaxContainer extends Component {
        constructor(props) {
            super(props);
            this.state = {
                isLoading: props.isAjaxRequest
            }
        }
        componentDidMount() {
            if (this.props.isAjaxRequest) {
                axios.request({
                    url:this.props.location.pathname,
                    method: 'get',
                    headers: {'X-Requested-With': 'XMLHttpRequest'}
                }).then((response) => {
                    this.props.contentActions.updateContent(response.data.Content);
                    this.setState({
                        isLoading: false
                    })
                }); 
                return;
            }
        this.props.ajaxContainerActions.updateAjaxRequestFlag(true);
        }

        render() {
             return <ComponentWithLoader isLoading={this.state.isLoading} {...this.props}/>;
        }
    }
    function mapStateToProps(state) {
        return {
            isAjaxRequest: state.Request.IsAjaxRequest,
        }
    }
    function mapDispatchToProps(dispatch) {
        return {
            ajaxContainerActions: bindActionCreators(ajaxContainerActions, dispatch),
            contentActions :bindActionCreators(contentActions,dispatch)
        }
    }
    return connect(mapStateToProps,mapDispatchToProps)(AjaxContainer);
};





export default AjaxComponent;