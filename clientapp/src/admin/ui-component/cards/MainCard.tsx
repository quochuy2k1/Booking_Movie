import { forwardRef, ReactNode } from 'react';

// material-ui
import { Card, CardContent, CardHeader, Divider, Typography } from '@mui/material';
import { Theme } from '@mui/system';

// constant
const headerSX: Array<Function
    | object
    | boolean>
    | Function
    | object = {
    '& .MuiCardHeader-action': { mr: 0 }
};

// ==============================|| CUSTOM MAIN CARD ||============================== //

interface ICardPropsStyle {
    border?: boolean,
    boxShadow?: boolean,
    children: ReactNode,
    content?: boolean,
    contentClass?: string,
    contentSX?: object,
    darkTitle?: boolean,
    secondary?: ReactNode,
    shadow?: string,
    sx?: object,
    title?: ReactNode,
}


const MainCard = forwardRef<HTMLDivElement | null, ICardPropsStyle>(
    (
        props: ICardPropsStyle,
        ref
    ) => {

        const {
            border = true,
            boxShadow,
            children,
            content = true,
            contentClass = '',
            contentSX = {},
            darkTitle,
            secondary,
            shadow,
            sx = {},
            title,
            ...others
        } = props;

        return (
            <Card
                ref={ref}
                {...others}
                sx={ (theme: Theme) => ({
                    border: border ? '1px solid' : 'none',
                    borderColor: theme.palette.primary[200] + 75,
                    ':hover': {
                        boxShadow: boxShadow ? shadow || '0 2px 14px 0 rgb(32 40 45 / 8%)' : 'inherit'
                    },
                    ...sx
                })}
            >
                {/* card header and action */}
                {!darkTitle && title && <CardHeader sx={headerSX} title={title} action={secondary} />}
                {darkTitle && title && (
                    <CardHeader sx={headerSX} title={<Typography variant="h3">{title}</Typography>} action={secondary} />
                )}

                {/* content & header divider */}
                {title && <Divider />}

                {/* card content */}
                {content && (
                    <CardContent sx={contentSX} className={contentClass}>
                        {children}
                    </CardContent>
                )}
                {!content && children}
            </Card>
        );
    }
);

export default MainCard;
