import React from 'react';
import PropTypes from 'prop-types';

const Hero = (props) => {
    const {Header,Description, CallToActionCaption,HeroBackground,CallToActionLink}=props;
    return (
        <section
            className="section section--full-height background-image-full overlay overlay--dark section--content-center section--thick-border"
            style={{backgroundImage: `url(${HeroBackground.Source})`}}>
            <div className="section__hero-content">
                <h1>{Header}</h1>
                <p className="section__description">{Description}</p>
                <a className="button button--border--solid" href={CallToActionLink}>
                    {CallToActionCaption}
                </a>

            </div>
        </section>
    )
};

Hero.propTypes = {
    Header: PropTypes.string.isRequired,
    Description: PropTypes.string.isRequired,
    CallToActionCaption: PropTypes.string.isRequired,
    CallToActionLink: PropTypes.string.isRequired,
    HeroBackground: PropTypes.object.isRequired
};

export default Hero;