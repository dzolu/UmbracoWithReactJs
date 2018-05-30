import React from 'react';
import PropTypes from 'prop-types';
import {NavLink} from "react-router-dom";

const TopNavigation = (props) => {
    return (
        props.topNavigation.map(item=>{
                return  <NavLink to={item.Url} className="nav-link" key={item.Id} activeClassName="navi-link--active">{item.Name}</NavLink>
            })
         
    )
};

TopNavigation.propTypes = {
    topNavigation: PropTypes.array.isRequired
};

export default TopNavigation;