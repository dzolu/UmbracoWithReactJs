import React, {Component} from 'react';
import {connect} from "react-redux";
import {bindActionCreators} from "redux"
import PropTypes from 'prop-types';
import Home from "../presentationComponents/Home";
import * as actions from "./../actions/ajaxContainerActions";

class HomeContainer extends Component {
    constructor(props, context) {
        super(props, context);
    }

    render() {
        return (
            
           <Home/>
        );
    }
}

HomeContainer.propTypes = {
//myPropTypes :PropTypes.string.require
};

function mapStateToProps(state, ownPros) {
    return {
        state: state
    }
}

function mapDispatchToProps(dispatch) {
    return {
        actions: bindActionCreators(actions, dispatch)
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(HomeContainer);