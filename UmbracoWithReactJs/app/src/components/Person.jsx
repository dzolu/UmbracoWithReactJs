import React from 'react';
import PropTypes from 'prop-types';

const Person = (props) => {
    const {DetailsModel, Social, Name} = props;
    return (
        <div className="employee-grid__item">
            <div className="employee-grid__item__image" style={{backgroundImage: `url(${DetailsModel.Photo.Source})`}}/>
            <div className="employee-grid__item__details">
                <h3 className="employee-grid__item__name">{Name}</h3>
            </div>
        </div>
    )
};

Person.propTypes = {
    DetailsModel: PropTypes.object.isRequired,
    Social: PropTypes.object.isRequired,
    Name : PropTypes.string.isRequired
};

export default Person;