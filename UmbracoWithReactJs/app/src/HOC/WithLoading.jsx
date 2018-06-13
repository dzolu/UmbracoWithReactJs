import React from 'react';

const WithLoading = (Component) => {
    return ({isLoading, ...props}) => {
        return (isLoading ? "Loading" : <Component {...props}/>)
    }
};

export default WithLoading;
      



