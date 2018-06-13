import React from 'react';
import PropTypes from 'prop-types';

const FooterHome = (props) => {
    return (
        <section className="section section--themed">

            <div className="container">
                <div className="row">
                    <div className="ta-center">
                        <h2>{props.Header}</h2>
                        <p className="section__description mw-640 ma-h-auto">{props.Description}</p>

                        <a className="button button--border--light_solid" href={props.CallToActionLink}>
                            {props.CallToActionCaption}
                        </a>

                    </div>

                </div>
            </div>

        </section>
    )
};

FooterHome.propTypes = {
    Header: PropTypes.string.isRequired,
    Description: PropTypes.string.isRequired,
    CallToActionCaption: PropTypes.string.isRequired,
    CallToActionLink: PropTypes.string.isRequired,
};

export default FooterHome;