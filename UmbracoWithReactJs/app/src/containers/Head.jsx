import React, {Component} from 'react';
import {connect} from "react-redux";
import PropTypes from 'prop-types';
import {Helmet} from "react-helmet";


class Head extends Component {
    constructor(props, context) {
        super(props, context);
    }

    render() {
        return (
            <Helmet>
                <title>{this.props.pageName} | {this.props.pageTitle}</title>
                <meta name="description" content={this.props.siteDescription}/>
            </Helmet>
        );
    }
}

Head.propTypes = {
    pageName: PropTypes.string.isRequired,
    pageTitle: PropTypes.string.isRequired,
    siteDescription: PropTypes.string.isRequired
};

function mapStateToProps(state) {
    return {
        pageName: state.MetaData.PageName,
        pageTitle: state.MetaData.PageTitle,
        siteDescription: state.MetaData.SiteDescription
    }
}


export default connect(mapStateToProps)(Head);