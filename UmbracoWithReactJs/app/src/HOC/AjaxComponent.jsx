import React, {Component} from 'react';
import WithLoading from "./WithLoading";
import axios from "axios";
import {connect} from "react-redux";
import * as ajaxContainerActions from "../actions/ajaxContainerActions";
import * as contentActions from "../actions/contentActions"
import {bindActionCreators} from "redux";
import DispatchService from "../Services/DispatchService"

const AjaxComponent = (WrappedComponent) => {
    const ComponentWithLoader = WithLoading(WrappedComponent);

    class AjaxContainer extends Component {
        constructor(props) {
            super(props);
            this.state = {
                isLoading: props.isAjaxRequest
            }
        }

        finishLoading() {
            this.setState({
                isLoading: false
            })
        }

        componentDidMount() {
            if (this.props.isAjaxRequest) {
                axios.request({
                    url: this.props.history.location.pathname,
                    method: 'get',
                    headers: {'X-Requested-With': 'XMLHttpRequest'}
                }).then((response) => {
                    DispatchService.routeChange(this.props, response.data);
                    this.finishLoading();
                });
                return;
            }
            DispatchService.initalLoadDone(this.props);
        }

        render() {
            return <ComponentWithLoader isLoading={this.state.isLoading} {...this.props}/>;
        }
    }

    function mapStateToProps(state) {
        return {
            isAjaxRequest: state.Request.IsAjaxRequest,
            id: state.Content.Id,
            location: state.location
        }

    }

    function mapDispatchToProps(dispatch) {
        return {
            ajaxContainerActions: bindActionCreators(ajaxContainerActions, dispatch),
            contentActions: bindActionCreators(contentActions, dispatch)
        }
    }

    return connect(mapStateToProps, mapDispatchToProps)(AjaxContainer);
};


export default AjaxComponent;