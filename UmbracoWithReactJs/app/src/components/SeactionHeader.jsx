import React from 'react';
import PropTypes from 'prop-types';

const SeactionHeader = (props) => {
    return (
        <section className="section section--themed section--header section--content-center-bottom">
            <div className="section__hero-content">
                <h1 className="no-air">{props.pageTitle}</h1>
            </div>
        </section>)
};

SeactionHeader.propTypes = {
    pageTitle: PropTypes.string.isRequired
};

export default SeactionHeader;