import React, { Component } from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Card from '@material-ui/core/Card';
import CardActions from '@material-ui/core/CardActions';
import CardContent from '@material-ui/core/CardContent';
import Button from '@material-ui/core/Button';
import Settings from '@material-ui/icons/Settings';
import AddAlertTwoToneIcon from '@material-ui/icons/AddAlertTwoTone';
import AccessAlarmsIcon from '@material-ui/icons/AccessAlarms';
import PersonAddIcon from '@material-ui/icons/PersonAdd';
import PaletteIcon from '@material-ui/icons/Palette';
import ImageIcon from '@material-ui/icons/Image';
import ArchiveIcon from '@material-ui/icons/Archive';
import UnarchiveIcon from '@material-ui/icons/Unarchive';
import MoreVertIcon from '@material-ui/icons/MoreVert';
import UndoIcon from '@material-ui/icons/Undo';
import RedoIcon from '@material-ui/icons/Redo';
import IconButton from '@material-ui/core/IconButton';
import Badge from '@material-ui/core/Badge';
import { ThemeProvider ,createMuiTheme} from '@material-ui/core'
import TextareaAutosize from '@material-ui/core/TextareaAutosize';
import { borderRadius } from '@material-ui/system';
import PropTypes from 'prop-types';
import Tooltip from '@material-ui/core/Tooltip';
import List from '@material-ui/core/List';
import ListItem from '@material-ui/core/ListItem';
import ListItemIcon from '@material-ui/core/ListItemIcon';
import ListItemText from '@material-ui/core/ListItemText';
import ClickAwayListener from '@material-ui/core/ClickAwayListener';
import  '../cssFiles/Notes.css';
import UserService from '../Services/UserService/UserService'


var axiosAddnote=new UserService;
const theme = createMuiTheme({
   
    overrides:{
       
        MuiPaper:{
            rounded:{ 
                width:"420px",
               
                borderRadius:"10px"
                
            }
        },
        MuiSvgIcon:{
            root:{
             
            }
        },
        TextareaAutosize:
        {
           border:"none"
           
        },
        MuiCardContent:{

              root:{
                minHeight:"10px"
              },
      
        }
      
    }
  });

export default  class Notes extends Component
{
  constructor()
  {
    super()
    this.state = {
        open: false,
        showMe: false,
        notesTitle:'',
        notesDescription:'',

      };

      this.noteAdd=this.noteAdd.bind(this);
      this.onchange=this.onchange.bind(this);
  }

  onchange(e)
  {
    this.setState({[e.target.name]: e.target.value});
    console.log(this.state);
  }
      operation = () => {
        this.setState({
          showMe: true,
        });
      };
    
       operationHide = () => {
       this.noteAdd()
      };

      noteAdd()
      {
        this.setState({
          showMe: false,
        });
          var data = {
                     
                      Title: this.state.notesTitle,                             
                      Description : this.state.notesDescription,
                    }
    
                    axiosAddnote.NoteCreate(data).then(response=>{
                      console.log(" response in ",response);
                 
                        
                      })
      }
    render(){
        const { open } = this.state;
        return(
            <div>
                
            <ThemeProvider theme={theme}>
           
            <div className="card-div" >
          
               <Card className="card-class">
                <CardContent id="card-content">   
                <div className="TextFieldTitle">
                    
                      <TextareaAutosize className="title-text-area"  onClick={this.operation} name="notesTitle"  onChange={this.onchange} placeholder="Title" />
                      {
                        this.state.showMe ?
                        <div className="TextField2">
                              <TextareaAutosize className="take-note-text-area" aria-multiline="true" name="notesDescription"  onChange={this.onchange} placeholder="Take A Note" />
                              <Tooltip title="Reminder" enterDelay={250} leaveDelay={10}>
                              <IconButton color="black">
                              <Badge  color="secondary">
                              < AccessAlarmsIcon precision={1} className="bottom-icon-list"/>
                              </Badge>
                              </IconButton>
                              </Tooltip>

                              <Tooltip title="Collaborate" enterDelay={250} leaveDelay={100}>
                              <IconButton color="black">
                              <Badge  color="secondary">
                              <PersonAddIcon  className="bottom-icon-list"/>
                              </Badge>
                              </IconButton>
                              </Tooltip>

                               <Tooltip title="Color" enterDelay={250} leaveDelay={100}>
                               <IconButton color="black">
                                <Badge  color="secondary">
                                <PaletteIcon  className="bottom-icon-list"/>
                                </Badge>
                                </IconButton>
                                </Tooltip>
                
                                <Tooltip title="Image" enterDelay={250} leaveDelay={100}>
                                <IconButton color="black">
                                <Badge  color="secondary">
                                <ImageIcon  className="bottom-icon-list"/>
                                </Badge>
                                </IconButton>
                                </Tooltip>

                                <Tooltip title="Archive" enterDelay={250} leaveDelay={100}>
                                <IconButton color="black">
                                 <Badge  color="secondary">
                                <ArchiveIcon  className="bottom-icon-list"/>   
                                </Badge>
                                </IconButton>
                                </Tooltip>

      
                                  <Tooltip title="More" enterDelay={250} leaveDelay={100}>
                                  <IconButton color="black">
                                  <Badge  color="secondary">
                                  <MoreVertIcon  className="bottom-icon-list"/>
                                  </Badge>
                                  </IconButton>
                                  </Tooltip>         
                                  <Button className="CloseButton" onClick={this.noteAdd}>close</Button>  
                                  
                        </div>
                      : null
             }
                </div>
            
               </CardContent>
          
               </Card>
                 
               </div>
         
               </ThemeProvider>

               
   
          </div>
        )
    }
}