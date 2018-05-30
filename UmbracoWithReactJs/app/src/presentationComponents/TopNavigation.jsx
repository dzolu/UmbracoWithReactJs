import React from 'react';
import PropTypes from 'prop-types';
import {Link} from "react-router-dom";

const TopNavigation = (props) => {
    return (
        props.topNavigation.map(item=>{
            return  <Link key={item.Id} to={item.Url}>{item.Name}</Link>
        })
    )
};

TopNavigation.propTypes = {
    topNavigation: PropTypes.array.isRequired
};

export default TopNavigation;