import React, {Component} from 'react';
import {connect} from "react-redux";
import {bindActionCreators} from "redux"
import PropTypes from 'prop-types';
import AjaxComponent from "../HOC/AjaxComponent";
import People from "../presentationComponents/People";

class PeopleContainer extends Component {
    constructor(props, context) {
        super(props, context);
    }

    render() {
        return (<People {...this.props}/>);
    }
}

PeopleContainer.propTypes = {
    pageTitle:PropTypes.string.isRequired,
    people: PropTypes.array.isRequired
};

function mapStateToProps(state, ownPros) {
    return {
        pageTitle: state.MetaData.PageTitle,
        people:state.Content.People
    }
}

function mapDispatchToProps(dispatch) {
    return {
        // actions: bindActionCreators(actions, dispatch)
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(AjaxComponent(PeopleContainer));