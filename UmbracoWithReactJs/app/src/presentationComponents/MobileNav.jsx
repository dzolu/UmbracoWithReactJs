import React from 'react';
import PropTypes from 'prop-types';
import TopNavigation from "./TopNavigation";

const MobileNav = (props) => {
    return (

        <div className="mobile-nav">
            <nav className="nav-bar">
                <TopNavigation topNavigation={props.topNavigation}/>
            </nav>
        </div>
    )
};

MobileNav.propTypes = {
    topNavigation: PropTypes.array.isRequired
};

export default MobileNav;