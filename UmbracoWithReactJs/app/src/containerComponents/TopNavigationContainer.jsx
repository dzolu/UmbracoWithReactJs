import React, {Component} from 'react';
import {connect} from "react-redux";
import {bindActionCreators} from "redux"
import PropTypes from 'prop-types';
import TopNavigation from "../presentationComponents/TopNavigation";

const TopNavigationContainer=()=>{
        return (
            <TopNavigation {...this.props}/>
        )

};
TopNavigation.Container.propTypes = {
    navigation :PropTypes.array.isRequired
};

function mapStateToProps(state, ownPros) {
    return {
        topNavigation: state.TopNavigation
    }
}

function mapDispatchToProps(dispatch) {
    return {
        actions: bindActionCreators(actions, dispatch)
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(TopNavigation.Container);