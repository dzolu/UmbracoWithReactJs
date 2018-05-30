import React from 'react';
import PropTypes from 'prop-types';
import TopNavigation from "./TopNavigation";

const Header = (props) => {
    return (
        <header className="header">
            <div className="logo">
                <a className="nav-link nav-link--home nav-link--home__text logo-text" href="/">DEMO SITE</a>
            </div>
            <nav className="nav-bar top-nav">
               <TopNavigation topNavigation={props.topNavigation}/>
            </nav>

            <div className="mobile-nav-handler">
                <div className="hamburger lines" id="toggle-nav">
                    <span></span>
                </div>
            </div>
    </header>
    )
};

Header.propTypes = {
    topNavigation: PropTypes.array.isRequired
};

export default Header;