import { forwardRef, ReactNode } from 'react';

// material-ui
import {  Collapse, Fade, Box, Grow, Slide, Zoom } from '@mui/material';


// ==============================|| TRANSITIONS ||============================== //

export interface ITransitionPropsType{
    children: ReactNode,
    type?: 'grow' | 'fade' | 'collapse' | 'slide' | 'zoom',
    position?: 'top-left'| 'top-right'| 'top'| 'bottom-left'| 'bottom-right'| 'bottom',
    direction?: 'up'| 'down'| 'left'| 'right',
    [others: string]: any
}
const Transitions = forwardRef<unknown, ITransitionPropsType>((props, ref) => {
    const { children, position, type, direction, sx, ...others } = props
    let positionSX = {
        transformOrigin: '0 0 0'
    };

    switch (position) {
        case 'top-right':
            positionSX = {
                transformOrigin: 'top right'
            };
            break;
        case 'top':
            positionSX = {
                transformOrigin: 'top'
            };
            break;
        case 'bottom-left':
            positionSX = {
                transformOrigin: 'bottom left'
            };
            break;
        case 'bottom-right':
            positionSX = {
                transformOrigin: 'bottom right'
            };
            break;
        case 'bottom':
            positionSX = {
                transformOrigin: 'bottom'
            };
            break;
        case 'top-left':
        default:
            positionSX = {
                transformOrigin: '0 0 0'
            };
            break;
    }

    return (
        <Box ref={ref} sx={sx}>
            {type === 'grow' && (
                <Grow {...others}>
                    <Box sx={positionSX}>{children}</Box>
                </Grow>
            )}
            {type === 'collapse' && (
                <Collapse {...others} sx={positionSX}>
                    {children}
                </Collapse>
            )}
            {type === 'fade' && (
                <Fade
                    {...others}
                    timeout={{
                        appear: 500,
                        enter: 600,
                        exit: 400
                    }}
                >
                    <Box sx={positionSX}>{children}</Box>
                </Fade>
            )}
            {type === 'slide' && (
                <Slide
                    {...others}
                    timeout={{
                        appear: 0,
                        enter: 400,
                        exit: 200
                    }}
                    direction={direction}
                >
                    <Box sx={positionSX}>{children}</Box>
                </Slide>
            )}
            {type === 'zoom' && (
                <Zoom {...others}>
                    <Box sx={positionSX}>{children}</Box>
                </Zoom>
            )}
        </Box>
    );
});





Transitions.defaultProps = {
    type: 'grow',
    position: 'top-left',
    direction: 'up'
};

export default Transitions;